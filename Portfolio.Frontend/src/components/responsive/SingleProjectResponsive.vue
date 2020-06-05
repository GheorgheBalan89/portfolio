<template>
    <div>
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

        <div v-if="project.Detail != null && project.Detail.Details != null" class="responsive-project-detail">
                    <div v-for="(detail, projId) in project.Detail.Details" :key="projId">
                        <div class="row">
                            <div v-if="detail.MediaItem" class="large-12 columns centered-content media-col">
                                <img :src="detail.MediaItem" alt="" />
                            </div>
                            <div v-if="detail.VideoUrl !=''  && detail.VideoUrl != null" class="large-12 columns centered-content media-col">
                                <iframe class="small-visible medium-hidden" :src="detail.VideoUrl" width="280" height="200" webkitallowfullscreen mozallowfullscreen allowfullscreen></iframe>
                                <iframe class="medium-visible small-hidden" :src="detail.VideoUrl" width="800" height="450" webkitallowfullscreen mozallowfullscreen allowfullscreen></iframe>
                                
                            </div>
                             <h3 class="project-title">{{detail.Heading}}</h3>
                            <div class="large-12 columns text-padding" v-html="detail.RichText"></div>
                        </div>
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