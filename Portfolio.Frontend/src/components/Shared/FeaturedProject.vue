<template>
    <div v-if="project" class="cell medium-4 text-center featured-project" @mouseover="hoverIn()" @mouseout="hoverOut()"  @click="featuredClick(project.Url)" v-bind:class="hoverClass" v-bind:style='{"background":"url("+project.FeaturedImage+") center center / cover"}'>
            <div v-if="isHovered" class="overlay">
            <h3>{{ project.Title }} </h3>
            <p> {{ project.Teaser }} </p>
            </div>
     </div>
</template>
<script>
import Vue from 'vue'
export default{
name:"FeaturedProject",
props: ['project'],
    data(){
        return {
            hoverClass: "",
            isHovered: ""
        };
    },
    methods: {
        featuredClick: function(url){
            window.location.href = url;
        },
        hoverIn: function(){
            this.isHovered = true;
            this.hoverClass = "zoomIn";
            // console.log("mouse in ");
        },
        hoverOut: function(){
            this.isHovered = false;
            this.hoverClass = "zoomOut";
            // console.log("mouse out");
        }
    },
    

}
</script>