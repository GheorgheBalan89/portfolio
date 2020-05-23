<template>
  <div id="project">
    <NavigationNerija/>
    <SingleProjectPage :projectid="projId" />
      <div class="large-visible medium-hidden">
        <Footer/> 
      </div>
    <div class="large-hidden medium-visible">
      <FooterResponsive/>
    </div>
  </div>
</template>

<script>

import NavigationNerija from '../components/Navigation/NavigationNerija'
import SingleProjectPage from '../components/SingleProject/SingleProjectPage'
import Footer from '../components/Footer'
import FooterResponsive from '../components/responsive/FooterResponsive'

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
    Footer,
    FooterResponsive
  }
}
</script>

<style lang="scss">
@import '../styles/app';
</style>