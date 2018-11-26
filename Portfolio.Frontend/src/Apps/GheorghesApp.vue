<template>
    <div>
         <div class="nav-container">
             <div v-if="this.scrollPosition < 80" name="fadeInDown" key="nav1"  delay="0s" duration="100ms" :iteration="1" :offset="0" animateClass="slideOutUp" :begin="true"  >
                  <NavigationGheorghe  />
             </div>
            <div v-else name="slideInUp" key="nav2" delay="0s" duration="100ms" :iteration="1" :offset="0" animateClass="slideInUp" :begin="true" >
                <NavigationInvertedGheorghe />
            </div>
         </div>
       <FeaturedProjects/>
       <ParallaxFacts/>
    </div>   
</template>
<script>
import Vue from 'vue'
import NavigationGheorghe from '../components/Navigation/NavigationGheorghe';
import NavigationInvertedGheorghe from '../components/Navigation/NavigationInvertedGheorghe';
import FeaturedProjects from '../components/Gheorghe/FeaturedProjects';
import FeaturedProject from '../components/Shared/FeaturedProject';
import ParallaxFacts from '../components/Gheorghe/ParallaxFacts';

Vue.component("FeaturedProject", FeaturedProject)

export default {
  name: 'GheorghesApp',
  components: {NavigationGheorghe, NavigationInvertedGheorghe, FeaturedProjects, ParallaxFacts},
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