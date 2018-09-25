<template>
<div>
    <div v-for="(project, projId) in projects" class="project-list-content-section" v-if="projId % 2 == 0">
         <div class="project-list-content-section-block small-order-2 medium-order-1">
            <h3 class="project-list-content-section-block-header">{{project.Title}}</h3>
            <p class="project-list-content-section-block-subheader subheader">{{project.Teaser}}</p>
            <a :href="project.Url" class="round button small">Read more</a>
        </div>
        <div class="project-list-content-section-img small-order-1 medium-order-2">
            <img src="https://images.pexels.com/photos/300857/pexels-photo-300857.jpeg?h=350&auto=compress&cs=tinysrgb" alt="" />
        </div>
    </div>

    <div class="project-list-content-section" v-else>
        <div class="project-list-content-section-img small-order-1 medium-order-1">
            <img src="https://images.pexels.com/photos/300857/pexels-photo-300857.jpeg?h=350&auto=compress&cs=tinysrgb" alt="" />
        </div>
        <div class="project-list-content-section-block small-order-2 medium-order-2">
            <h3 class="project-list-content-section-block-header">{{project.Title}}</h3>
            <p class="project-list-content-section-block-subheader subheader">{{project.Teaser}}</p>
            <a :href="project.Url" class="round button small">Read more</a>
        </div>
    </div>
</div>
</template>

<script>
import axios from "axios"
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
            this.projects = response.data.Projects
        });
        
    },
}
</script>