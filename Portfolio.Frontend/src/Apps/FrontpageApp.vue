<template>
  <div>
    <NavigationNerija/>
    <Frontpage/>
    <Footer/>
  </div>
</template>

<script>

import NavigationNerija from '../components/Navigation/NavigationNerija'
import Frontpage from '../components/Pages/Frontpage'
import Footer from '../components/Footer'

export default {
  name: 'FrontpageApp',
  components:{
    NavigationNerija,
    Frontpage,
    Footer
  }
}
</script>

<style lang="scss">
@import '../styles/app';
</style>
