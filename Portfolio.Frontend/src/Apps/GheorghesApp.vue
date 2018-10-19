<template>
    <div>
         <u-animate-container  class="nav-container">
             <u-animate v-if="this.scrollPosition < 80" name="fadeInDown" key="nav1"  delay="0s" duration="100ms" :iteration="1" :offset="0" animateClass="slideOutUp" :begin="true"  >
                  <NavigationGheorghe  />
             </u-animate>
            <u-animate v-else name="slideInUp" key="nav2" delay="0s" duration="100ms" :iteration="1" :offset="0" animateClass="slideInUp" :begin="true" >
                <NavigationInvertedGheorghe />
            </u-animate>
         </u-animate-container>
       <FeaturedProjects/>
    </div>   
</template>
<script>
import Vue from 'vue'
import VueWow from 'vue-wow'
import NavigationGheorghe from '../components/Navigation/NavigationGheorghe';
import NavigationInvertedGheorghe from '../components/Navigation/NavigationInvertedGheorghe'
import FeaturedProjects from '../components/Gheorghe/FeaturedProjects'
import FeaturedProject from '../components/Shared/FeaturedProject'

Vue.component("FeaturedProject", FeaturedProject)

Vue.use(VueWow)
import {UAnimateContainer, UAnimate} from 'vue-wow'

export default {
  name: 'GheorghesApp',
  components: {NavigationGheorghe, NavigationInvertedGheorghe, FeaturedProjects},
    data(){
        return{
            scrollPosition: ""
        }
    },
    methods:{
        updateScroll: function(){
            this.scrollPosition = Number(window.scrollY);
        }
    },
    created(){
          window.addEventListener('scroll', this.updateScroll);
    },
    destroy() {
         window.removeEventListener('scroll', this.updateScroll)
    }
}
</script>

<style lang="scss">
@import '../styles/app';
</style>