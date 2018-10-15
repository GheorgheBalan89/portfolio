<template>
    <div class="grid-container fluid  front-page-featured">
         <h1 class="text-center">Lorem ipsum</h1>
         <template  v-for="(project, key) in projects">
            <div class="grid-x grid-margin-x " v-if="key %3 == 0">              
                    <div class="cell medium-4 text-center featured-project"  @click="featuredClick(projects[key].Url)"  v-bind:style='{"background":"url("+projects[key].FeaturedImage+") center center / cover", "height":"450px"}'>
                        <!-- <img :src="projects[key].FeaturedImage"/> -->
                        <h3>{{ projects[key].Title }} </h3>
                        <p> {{ projects[key].Teaser }} </p>
                    </div>

                     <div v-if="projects[key +1] != null" class="cell medium-4 text-center featured-project" @click="featuredClick(projects[key +1].Url)" v-bind:style='{"background":"url("+projects[key +1].FeaturedImage+") center center / cover", "height":"450px"}'>
                        <!-- <img :src="projects[key +1].FeaturedImage"/> -->
                        <h3>{{ projects[key + 1].Title }} </h3>
                        <p> {{ projects[key + 1].Teaser }} </p>
                    </div>
                     <div v-if="projects[key +2] != null" class="cell medium-4 text-center featured-project" @click="featuredClick(projects[key +2].Url)" v-bind:style='{"background":"url("+projects[key +2].FeaturedImage+") center center / cover", "height":"450px"}'>
                        <!-- <img :src="projects[key +2].FeaturedImage"/> -->
                        <h3>{{ projects[key + 2].Title }} </h3>
                        <p> {{ projects[key + 2].Teaser }} </p>
                    </div>
             </div>

            </template>
        </div>
   
</template>

<script>

import axios from "axios"

export default{
    name: 'Frontpage',
    data(){
        return {
            projects: "",
        };
    },
    mounted(){
        axios.get("/umbraco/Api/ProjectsApi/GetFeaturedProjects").then(response => {
            console.log(response.data.Projects);
            this.projects = response.data.Projects;
        });
        
    },
        methods: {
            featuredClick: function(url){
                console.log(url);
                window.location.href = url;
        }
    }

}
</script>