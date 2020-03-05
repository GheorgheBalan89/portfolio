<template>
    <div class="projectlist-container">
        
        <div class="grid-x">
        <template v-if="projects != null" >
            <template v-for="topProj in topProjects">
                <FeaturedProject :project="topProj" v-bind:key="topProj.Udi"/>
            </template>
            <div v-if="!expandedView && restProjects!= null" class="cell large-12 text-center show-more-container">
                 <button class="hollow button primary" @click="showMore()">  <font-awesome-icon icon="chevron-circle-down" /> Show more </button>
            </div>
            <template v-if="expandedView && restProjects !=null " v-for="(restProj, key3) in restProjects">
                    <FeaturedProject :project="restProj" v-bind:key="restProj.Udi"/>
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
import FeaturedProject from '../Shared/FeaturedProject'

export default{
    name: "ProjectList",
    props:['projects', 'topProjects', 'restProjects'],
    data(){
        return {
            cv:"",
            cvText:"",
            expandedView: false,
            count: 0
        }
    },
    mounted(){       
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
    components: {
        FeaturedProject
    }
}
</script>