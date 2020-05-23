<template>
    <div class="cell medium-4 featured-project" v-if="project"  @mouseenter="isHoverIn = true" @mouseleave="isHoverIn = false"  @click="featuredClick(project.Url)" :key="project.Udi" >
        <img :src="project.General.FeaturedImage" :alt="project.Title" width="100%"/>   
            <div class="animation-container">
            <transition-group name="fade" enter-active-class="fadeIn" leave-active-class="fadeOut"  tag="div">    
                <div v-if="isHoverIn" class="overlay" v-bind:key="project.Udi" style="animation-duration: 0.3s;">
                    <h3 class="text-center title">{{ project.General.Title }} </h3>
                    <p class="text-center"> {{ project.General.Teaser }} </p>
                    <p class="text-center">Read more </p>
                </div>
            </transition-group>
        </div>                       
     </div>
</template>
<script>
import Vue from 'vue'

export default{
name:"ProjectDetail",
props: ['project'],
    data(){
        return {
            isHoverIn: "",
        };
    },
    methods: {
        featuredClick: function(url){
            window.location.href =  url;
         }
    }
}
</script>