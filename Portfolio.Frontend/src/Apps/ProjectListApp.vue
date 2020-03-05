<template>
  <div id="projectlist">
    <NavigationNerija/>
    <Parallax :projectMeta="meta"/>
    <ProjectList :projects="projList" :topProjects="topList" :restProjects="bottomList"/>
    <Footer/> 
  </div>
</template>

<script>

import NavigationNerija from '../components/Navigation/NavigationNerija'
import Parallax from '../components/Shared/Parallax'
import ProjectList from '../components/Pages/ProjectList'
import Footer from '../components/Footer'
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
            
            console.log(projects);
            console.log("path "+ window.location.origin + window.location.pathname);
            this.count = projects.length;
         
            if(projects.length > 3){
                this.topList = projects.slice(0,3);
                this.bottomList = projects.slice(3, projects.length);     
                console.log(this.bottomList);

            }
            this.meta = response.data;
            console.log(this.meta);
       });
  },
 components:{
    NavigationNerija,
    Parallax,
    ProjectList,
    Footer
  }
}
</script>

<style lang="scss">
@import '../styles/app';
</style>