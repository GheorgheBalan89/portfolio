<template>
    <section class="light-bg section-container" id="featured-projects">
        <div class="grid-x margin-x">
            <div class="cell large-12">
                <h3 class="text-center uppercase">Featured Projects</h3>
            </div>
            <div class="cell large-12">
                <p class="text-center"> Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium,
                    totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. 
                </p>
            </div>
             <div class="cell large-12 text-center">
                 <button class="hollow button success">  <font-awesome-icon icon="code" /> CODE </button>
                 <button class="hollow button success"> <font-awesome-icon icon="shopping-cart" /> COMMERCE</button>
                 <button class="hollow button success"> <font-awesome-icon icon="users-cog" /> CMS </button>
                 <button class="hollow button success"> Type 4</button>
            </div>            
        </div>
      
        <div class="grid-container featured-container">
            <div class="grid-x">
                <template v-for="(item, key) in projects">
                    <FeaturedProject :project="item" v-bind:key="key"/>
                </template>
            </div>
        </div>
        <div class="grid-x">
            <div class="cell large-12 text-center">
                <button class="button success">View More</button>
            </div>
        </div>
    </section>
</template>
<script>
import axios from "axios"


export default{
    name: "FeaturedProjects",
    methods: {    

    },
     data(){
        return {
            projects: "",
        };
    },
    mounted(){
        axios.get("/umbraco/Api/ProjectsApi/GetFeaturedProjects?website=Gheorghe").then(response => {
            console.log(response.data.Projects);
            this.projects = response.data.Projects;
        });
        
    },
}
</script>