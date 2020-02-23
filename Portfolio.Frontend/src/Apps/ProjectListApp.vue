<template>
  <div id="projectlist">
    <NavigationNerija/>
    <Parallax/>
    <ProjectList/>
    <Footer/> 
  </div>
</template>

<script>

import NavigationNerija from '../components/Navigation/NavigationNerija'
import Parallax from '../components/Shared/Parallax'
import ProjectList from '../components/Pages/ProjectList'
import Footer from '../components/Footer'

export default {
  name: 'ProjectListApp',
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