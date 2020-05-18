<template>
  <div id="project">
    <NavigationNerija/>
    <SingleProjectPage :projectid="projId" />
    <Footer/> 
  </div>
</template>

<script>

import NavigationNerija from '../components/Navigation/NavigationNerija'
import SingleProjectPage from '../components/SingleProject/SingleProjectPage'
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
    SingleProjectPage,
    Footer
  }
}
</script>

<style lang="scss">
@import '../styles/app';
</style>