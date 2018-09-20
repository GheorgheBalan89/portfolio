<template>
    <div class="grid-container fluid  front-page-featured">
         <h1 class="text-center">Lorem ipsum</h1>
        <div class="grid-x grid-margin-x align-center">
            <div v-for=" project in featuredProjects" class="cell medium-6 text-center featured-project" @click="featuredClick(project.Url)" >
                <img :src="project.FeaturedImage"/>
                <h3>{{ project.Title }} </h3>
                <p> {{ project.Teaser }} </p>
            </div>
            
        </div>
    </div>
</template>

<script>

import axios from "axios"

export default{
    name: 'Frontpage',
    data(){
        return {
            featuredProjects: "",
        };
    },
    mounted(){
        axios.get("/umbraco/Api/ProjectsApi/GetFeaturedProjects").then(response => {
            console.log(response.data.Projects);
            this.featuredProjects = response.data.Projects;
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