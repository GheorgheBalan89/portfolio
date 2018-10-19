<template>
    <section class="light-bg section-container ">
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
                 <button class="hollow button success" href="#">Type 1</button>
                 <button class="hollow button success" href="#">Type 2</button>
                 <button class="hollow button success" href="#">Type 3</button>
                 <button class="hollow button success" href="#">Type 4</button>
            </div>            
        </div>
      
            <template v-for="(project, key) in projects">
            <div class="grid-x" v-if="key %3 == 0">              
                <FeaturedProject :project="projects[key]"/>
                <FeaturedProject v-if="projects[key +1] != null" :project="projects[key + 1]"/>
                <FeaturedProject v-if="projects[key +2] != null" :project="projects[key + 2]"/>
             </div>
            </template>
      
            <div v-for="n in 10">
                "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?"
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