<template>
    <section class="fluid section-container">
         <h1 class="text-center">Lorem ipsum</h1>
            <div class="grid-container featured-container">
                <div class="grid-x">
                 <!-- <template v-for="(item, key) in projects">
                        <FeaturedProject :project="item" v-bind:key="key"/>
                 </template> -->
                </div>
            </div>
        </section>
</template>

<script>

import axios from "axios"

export default{
    name: 'Frontpage',
    data(){
        return {
            projects: "",
            show:""
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