<template>
    <div class="projectlist-container">
        <div class="grid-x headline-container">
            <div class="medium-12 ">
                <h1 class="text-center">
                    <div class="stroke"></div>
                    <span>{{projectMeta.Heading1}}</span>
                    <div class="stroke"></div>
                </h1>
            </div>
            <div class="medium-12">
                <h2 class="text-center">{{projectMeta.Heading2}}</h2>
            </div>
        </div>
        <div class="grid-x">
            <template v-if="projects != null && count <= 3" v-for="(item, key) in projects">
                <FeaturedProject :project="item" v-bind:key="key"/>
            </template>
            <template v-else>
                <template v-for="(item, key) in topProjects">
                    <FeaturedProject :project="item" v-bind:key="key"/>
                </template>

                <div v-if="!expandedView" class="cell large-12 text-center show-more-container">
                    <button class="hollow button primary" @click="showMore()">  <font-awesome-icon icon="chevron-circle-down" /> Show more </button>
                </div>

                <template v-if="expandedView" v-for="(item, key) in projects">
                    <FeaturedProject :project="item" v-bind:key="key"/>
                </template>

                 <div v-if="expandedView" class="cell large-12 text-center show-more-container">
                    <button class="hollow button primary" @click="showLess()">  <font-awesome-icon icon="chevron-circle-up" /> Show less </button>
                </div>

            </template>
        </div>
    </div>
</template>

<script>
import Vue from 'vue'
import axios from "axios"
import { page } from 'vue-analytics'

export default{
    name: "ProjectList",
    data(){
        return {
            projectMeta:"",
            projects :"",
            topProjects: "",
            cv:"",
            cvText:"",
            expandedView: false,
            count: 0
        }
    },
    mounted(){
        var getUrl = "/umbraco/Api/ProjectsApi/GetProjects?website=Nerija";
        axios.get(getUrl).then(response => {
            var projects = response.data.Projects;
            this.projects = projects;

            console.log("path "+ window.location.origin +"/"+ window.location.pathname);
            this.count = projects.length;
         
            if(projects.length > 3){
                this.topProjects = projects.slice(0,3);
                this.projects = projects.slice(3, projects.length);     
            }
            this.projectMeta = response.data;
            console.log(this.projectMeta);
       });
        
        var getcv = "/umbraco/Api/ContentApi/GetResume?websiteName=Nerija";
            axios.get(getcv).then(response => {
            this.cv = response.data.Cv;
            this.cvText = response.data.CvText;
       });
        
    },
      methods: {
        showMore: function(){
             this.expandedView = true;
        },
         showLess: function(){
             this.expandedView = false;
        },
        track: function(){
            var pathname =  window.location.origin + window.location.pathname;
           page(pathname);
        }
        
    },
}
</script>