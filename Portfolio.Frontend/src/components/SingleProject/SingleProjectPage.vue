<template>
        <div v-if="project != null" class="projectlist-container details-bg">
            <div v-if="project.Detail != null" class="hero-section">  
                <div class="hero-section-text">
                    <h1 class="large-visible">   
                        {{project.General.Title}}
                    </h1>
                    <h2 class="large-hidden medium-visible">
                        {{project.General.Title}}
                    </h2>
                     <div class="text-center">
                        <h5> Client: {{project.Detail.ClientName}} 
                             <br> Year: {{project.Detail.Year}} 
                             <br/> Role: {{ project.Detail.Role}}
                        </h5> 
                    </div>
                    <div class="hero-description " v-html="project.General.Description"></div>
                </div>
            </div>
            <ContentRow :rows="project.ContentRows"/>
        </div>
</template>

<script>
import axios from "axios"
import ContentRow from "../SingleProject/ContentRow"
export default{  
    name : "SingleProjectPage",
    props: ["project"],
    methods:{
         track: function(){
            var pathname =  window.location.origin + window.location.pathname;
           page(pathname);
        }  
    },
    components:{
        ContentRow
  }
}
</script>