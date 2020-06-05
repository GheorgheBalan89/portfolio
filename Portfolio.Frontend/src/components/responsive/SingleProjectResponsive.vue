<template>
       <div v-if="project != null">
           <div v-if="project.Detail != null" class="hero-section-responsive" v-bind:style="{ 'background-image': 'url(' + project.Detail.Hero + ')'}">  
                <div class="hero-section-text">
                    <h1>   
                        {{project.General.Title}}
                    </h1>
                   <div class="text-center">
                        <h5> Client: {{project.Detail.ClientName}}  <br> Year: {{project.Detail.Year}} <br/> Role: {{ project.Detail.Role}}</h5> 
                    </div>
                    <div class="hero-description " v-html="project.General.Description"></div>
                </div>
            </div>
       </div>
</template>


<script>
import axios from "axios"

export default{  
    name : "SingleProjectResponsive",
    props: ["project"],
    data(){
        return {
            project:""
        }
    }
}
</script>