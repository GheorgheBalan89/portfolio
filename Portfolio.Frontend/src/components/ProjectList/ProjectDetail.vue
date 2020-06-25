<template>
    <div class="cell medium-4 featured-project" v-if="project"  @mouseenter="isHoverIn = true"  @mouseleave="isHoverIn = false"   @click="featuredClick(project.Url)" :key="project.Udi" >
         <transition-group name="slide-fade" class="overlay-container" tag="div">
              <img v-if="isHoverIn !=null" :src="isHoverIn == null|| isHoverIn == '' || !isHoverIn ? project.ListDetail.WebListImage : project.ListDetail.WebListPlaceholder " :alt="project.Title" class="overlay" key="startImg" width="100%"/>   
              <h3 v-if="isHoverIn == null|| isHoverIn == '' || !isHoverIn" class="text-center placeholder-title inactive" key="startTitle"> {{project.General.Title}}</h3>
              <h3 v-if="isHoverIn != null && isHoverIn" class="activeTitle" key="activeTitle">{{project.General.Title}}</h3>
              <h4 v-if="isHoverIn != null && isHoverIn" class="activeDescription" key="activeDescription">{{project.General.Teaser}}</h4>
              <h5  v-if="isHoverIn != null && isHoverIn" class="readMore" key="readMore"> Read more</h5>
        </transition-group>
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