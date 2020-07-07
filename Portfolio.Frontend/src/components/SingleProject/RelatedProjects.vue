<template>
<div v-if="relatedProjects != null">
     <div class="text-center related-heading">
            <h4>More like this</h4>
         </div>
    <div class="grid-x related-projects-container">
        
     <div class="cell medium-4 related-project text-center" v-for="project in relatedProjects"   @click="featuredClick(project.Url)" :key="project.Udi" >
            <img :src="project.WebListImage " :alt="project.Title" width="100%"/>   
             <h3>{{project.Title}}</h3>
                     
       </div>
    </div>
</div>
</template>

<script>
import axios from "axios"

export default{  
    name : "RelatedProjects",
    props: ["relatedProjects"],
     methods: {
        featuredClick: function(url){
            window.location.href =  url;
         }
    }
}
</script>