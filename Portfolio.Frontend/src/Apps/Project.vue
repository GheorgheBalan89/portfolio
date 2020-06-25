<template>
  <div id="project">
    <NavigationNerija/>
     <div class="large-visible medium-hidden">
         <SingleProjectPage :project="project" />
        <Footer/> 
      </div>
      <div class="large-hidden medium-visible">
         <SingleProjectResponsive :project="project" />
      <FooterResponsive/>
    </div>
  </div>
</template>

<script>

import NavigationNerija from '../components/Navigation/NavigationNerija'
import SingleProjectPage from '../components/SingleProject/SingleProjectPage'
import Footer from '../components/Footer'
import SingleProjectResponsive from '../components/responsive/SingleProjectResponsive'
import FooterResponsive from '../components/responsive/FooterResponsive'
import axios from "axios"

export default {
  name: 'Project',
  data(){
   return{
        project:""
   }
 },
   mounted(){
        var pidUrl = "/umbraco/Api/ProjectsApi/GetProject/ssqq?projectId="+ document.getElementById("pid").value + "";
        axios.get(pidUrl).then(response => {
              this.project = response.data
        });
    },
 components:{
    NavigationNerija,
    SingleProjectPage,
    Footer,
    SingleProjectResponsive,
    FooterResponsive
  }
}
</script>

<style lang="scss">
@import '../styles/app';
</style>