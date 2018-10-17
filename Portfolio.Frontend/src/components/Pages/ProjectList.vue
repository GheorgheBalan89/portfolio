<template>
<div>
    <u-animate-container>
        <u-animate v-for="(project, projId) in projects" v-if="projId % 2 == 0" name="bounceInRight" :key="projId"  delay="0s" duration="2s" :iteration="1" :offset="0" animateClass="bounceInRight" :begin="false"  >
            <div  class="project-list-content-section">
                <div class="project-list-content-section-block small-order-2 medium-order-1">
                    <h3 class="project-list-content-section-block-header">{{project.Title}}</h3>
                    <p class="project-list-content-section-block-subheader subheader">{{project.Teaser}}</p>
                    <a :href="project.Url" class="round button small">Read more</a>
                </div>
                <div class="project-list-content-section-img small-order-1 medium-order-2">
                    <img src="https://images.pexels.com/photos/300857/pexels-photo-300857.jpeg?h=350&auto=compress&cs=tinysrgb" alt="" />
                </div>
            </div>
        </u-animate>
        <u-animate  v-else name="bounceInLeft"  delay="0s" duration="2s" :key="projId" :iteration="1" :offset="0" animateClass="bounceInLeft" :begin="false">
            <div class="project-list-content-section slideInRight">
                    <div class="project-list-content-section-img small-order-1 medium-order-1">
                        <img src="https://images.pexels.com/photos/300857/pexels-photo-300857.jpeg?h=350&auto=compress&cs=tinysrgb" alt="" />
                    </div>
                    <div class="project-list-content-section-block small-order-2 medium-order-2">
                        <h3 class="project-list-content-section-block-header">{{project.Title}}</h3>
                        <p class="project-list-content-section-block-subheader subheader">{{project.Teaser}}</p>
                        <a :href="project.Url" class="round button small">Read more</a>
                    </div>
                </div>
        </u-animate>
    </u-animate-container>
</div>
</template>

<script>
import Vue from 'vue'
import axios from "axios"
import VueWow from 'vue-wow'
Vue.use(VueWow)

import {UAnimateContainer, UAnimate} from 'vue-wow'

export default{
    name: "ProjectList",
    data(){
        return {
            projects :""
        }
    },
    mounted(){
        var getUrl = "/umbraco/Api/ProjectsApi/GetProjects";
        axios.get(getUrl).then(response => {
            this.projects = response.data.Projects;
        
       });
        
    },
}
</script>