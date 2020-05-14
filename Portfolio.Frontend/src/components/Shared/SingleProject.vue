<template>
    <div class="cell medium-4 featured-project" v-if="project"  @mouseenter="hoverIn()" @mouseleave="hoverOut()"  @click="featuredClick(project.Url)" :key="project.Udi" >
        <img :src="project.FeaturedImage" :alt="project.Title" width="100%"/>   
            <div class="animation-container">
            <transition-group name="fade" enter-active-class="fadeIn" leave-active-class="fadeOut"  tag="div">    
                <div v-if="isHoverIn" class="overlay" v-bind:key="project.Udi" style="animation-duration: 0.3s;">
                    <p class="text-center title">{{ project.Title }} </p>
                    <p class="text-center"> {{ project.Teaser }} </p>
                </div>
            </transition-group>
        </div>                       
     </div>
</template>
<script>
import Vue from 'vue'

export default{
name:"SingleProject",
props: ['project'],
    data(){
        return {
            isHoverIn: "",
        };
    },
    methods: {
        featuredClick: function(url){
            window.location.href =  url;
        },
        hoverIn: function(){
            this.isHoverIn = true;             
        },
        hoverOut: function(){
            this.isHoverIn = false;        
        }
    },   

}
</script>