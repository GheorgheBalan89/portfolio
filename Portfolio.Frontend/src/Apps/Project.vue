<template>
  <div id="project">
    <NavigationNerija/>
    <Project :projectid="projId" />
    <Footer/> 
  </div>
</template>

<script>

import NavigationNerija from '../components/Navigation/NavigationNerija'
import Project from '../components/SingleProject/Project'
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
    Project,
    Footer
  }
}
</script>

<style lang="scss">
@import '../styles/app';
</style>