<template>
  <div id="projectlist">
    <NavigationNerija/>
    <ProjectList/>
    <Footer/> 
  </div>
</template>

<script>

import NavigationNerija from '../components/Navigation/NavigationNerija'
import ProjectList from '../components/Pages/ProjectList'
import Footer from '../components/Footer'

export default {
  name: 'ProjectListApp',
 components:{
    NavigationNerija,
    ProjectList,
    Footer
  }
}
</script>

<style lang="scss">
@import '../styles/app';
</style>