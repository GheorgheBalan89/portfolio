<template>
  <div id="project">
    <NavigationNerija/>
    <ProjectDetails :projectid="projId" />
    <Footer/> 
  </div>
</template>

<script>

import NavigationNerija from '../components/Navigation/NavigationNerija'
import ProjectDetails from '../components/Pages/ProjectDetails'
import Footer from '../components/Footer'

export default {
  name: 'Project',
  data(){
   return{
     projId: document.getElementById("pid").value
   }
 },
 components:{
    NavigationNerija,
    ProjectDetails,
    Footer
  }
}
</script>

<style lang="scss">
@import '../styles/app';
</style>