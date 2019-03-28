<template>
  <div>
    <NavigationNerija/>
    <AboutPage/>
    <Footer/>
  </div>
</template>

<script>
import NavigationNerija from '../components/Navigation/NavigationNerija'
import AboutPage from '../components/Pages/AboutPage'
import Footer from '../components/Footer'

export default {
  name: 'FrontpageApp',
  components:{
    NavigationNerija,
    AboutPage,
    Footer
  }
}
</script>

<style lang="scss">
@import '../styles/app';
</style>
