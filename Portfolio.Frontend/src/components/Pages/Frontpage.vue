<template>
    <section class="fluid section-container">
         <h1 class="text-center">Lorem ipsum</h1>
         <template  v-for="(project, key) in projects">
              <div class="grid-x" v-if="key %3 == 0">              
                <FeaturedProject :project="projects[key]"/>
                <FeaturedProject v-if="projects[key +1] != null" :project="projects[key + 1]"/>
                <FeaturedProject v-if="projects[key +2] != null" :project="projects[key + 2]"/>
             </div>
            </template>
        </section>
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
        axios.get("/umbraco/Api/ProjectsApi/GetFeaturedProjects?website=Nerija").then(response => {
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