<template>
     <div class="rocket-animation-container" id="rockets"  @mouseenter="isHoverIn = true">
        <img class="rockets"  src="/static/Rockets/Rockets.svg">
        <!-- <div class="shadow-container animation-container"  v-on:scroll.passive="handleScroll()">  -->
          <transition-group name="bounce-in" class="smoke-container" tag="div"> 
                <img v-if="isHoverIn" src="/static/Rockets/rocketSmoke.svg" alt="small-smoke-1" key="smoke-1"/>
         </transition-group>
          <div class="shadow-container animation-container"> 
                <transition  name="slide-in" key="back" tag="div">
                    <div v-if="isHoverIn" class="back-shadows"></div>
                </transition>
                <transition name="slide-in" key="front" tag="div">
                    <div v-if="isHoverIn" class="front-shadows"></div>
                </transition>
        </div>

      
     </div>
</template>
<script>

import Vue from 'vue';
import Velocity from 'velocity-animate';

export default {
    name :"Rockets",
     data(){
        return {
            hasScrolled: "",
            isHoverIn: ""
        }
    }
}
</script>