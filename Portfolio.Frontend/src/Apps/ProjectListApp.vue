<template>
  <div>
    <div id="projectlist" class="large-visible medium-hidden">
      <NavigationNerija/>
      <Parallax :projectMeta="meta"/>
      <ProjectList :projects="projList" :topProjects="topList" :restProjects="bottomList"/>
      <Footer/> 
    </div>
    <div class="large-hidden medium-visible">
      <NavigationNerija/>
      <ProjectListMeta :meta="meta"/>
      <ProjectListResponsive :projects="projList"/>
      <FooterResponsive/>
    </div>
  </div>
</template>

<script>

import NavigationNerija from '../components/Navigation/NavigationNerija'
import Parallax from '../components/ProjectList/Parallax'
import ProjectListMeta from '../components/responsive/ProjectListMeta'
import ProjectList from '../components/ProjectList/ProjectList'
import ProjectListResponsive from '../components/responsive/ProjectListResponsive'
import Footer from '../components/Footer'
import FooterResponsive from '../components/responsive/FooterResponsive'
import axios from "axios"

export default {
  name: 'ProjectListApp',
  data(){
    return{
        meta:"",
        projList :"",
        topList: "",
        bottomList: "",
    }
  },
  mounted(){
       var getUrl = "/umbraco/Api/ProjectsApi/GetProjects?website=Nerija";
        axios.get(getUrl).then(response => {
            var projects = response.data.Projects;
            this.projList = projects;         
            this.count = projects.length;
            if(projects.length > 9){
                this.topList = projects.slice(0,9);
                this.bottomList = projects.slice(9, projects.length);     
                console.log(this.bottomList);
            }else{
              this.topList = projects;
              // this.bottomList = null;
            }
            this.meta = response.data;

       });
  },
 components:{
    NavigationNerija,
    Parallax,
    ProjectList,
    ProjectListMeta,
    ProjectListResponsive,
    Footer,
    FooterResponsive
  }
}
</script>

<style lang="scss">
@import '../styles/app';
</style>