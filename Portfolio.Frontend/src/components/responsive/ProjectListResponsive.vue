<template>
    <div class="parent-container">
            <div class="project-list-header">
                <h4 class="text-center">Projects</h4>
            </div>
            <div class="projects-container text-center" v-if="projects != null" >
                <div v-for="project in projects" class="project"   @click="viewDetail(project.Url)" :key="project.Udi"> 
                 <div>              
                    <img :src="project.General.FeaturedImage" :alt="project.General.Title" width="100%"/>   
                        <div>
                            <p class="text-center">{{ project.General.Title }} </p>
                        </div>
                    </div> 
                </div>
            </div>
        </div>
</template>

<script>
import Vue from 'vue'
import axios from "axios"
import { page } from 'vue-analytics'

export default{
    name: "ProjectListResponsive",
    props:['projects'],
    data(){
        return {
          count: 0
        }
    },
      methods: {
        track: function(){
            var pathname =  window.location.origin + window.location.pathname;
           page(pathname);
        },
        viewDetail: function(url){
            window.location.href =  url;
        }

    }
  
}
</script>