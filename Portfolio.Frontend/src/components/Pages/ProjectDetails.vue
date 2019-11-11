<template>
        <div class="projectlist-container details-bg">
            <div class="hero-section" v-bind:style="{ 'background-image': 'url(' + project.Hero + ')'}">  
                <div class="hero-section-text">
                    <h3>   
                        <div class="stroke hide-for-small-only"></div>
                        {{project.Title}}
                        <div class="stroke hide-for-small-only"></div>
                    </h3>
                     <div class="text-center">
                        <h5> Client: {{project.ClientName}}  <br> Year: {{project.Year}} <br/> Role: {{ project.Role}}</h5> 
                    </div>
                    <div class="hero-description hide-for-small-only" v-html="project.Description"></div>
                </div>
            </div>

            <div class="row show-for-small-only">
                <div class="large-12 columns" v-html="project.Description"></div>
            </div>
            <div class="hide-for-small-only">
                <div v-for="(detail, projId) in project.Details" v-if="projId % 2 == 0"  :key="projId">
                    <div  class="project-details-section">
                        <div class="project-details-section-block small-order-2 medium-order-1">
                            <h3 class="project-details-section-block-header">{{detail.Heading}}</h3>
                            <div class="details-richtext" v-html="detail.RichText"></div>
                        </div>

                        <div v-if="detail.MediaItem" class="project-details-section-img small-order-1 medium-order-2">
                            <img :src="detail.MediaItem" alt="" />
                        </div>
                          <div v-if="detail.VideoUrl !=''  && detail.VideoUrl != null" class="project-details-section-img small-order-1 medium-order-1">
                                <iframe :src="detail.VideoUrl"  width="952" height="450"  webkitallowfullscreen mozallowfullscreen allowfullscreen></iframe>
                          </div>
                    </div>
                </div>
                <div v-else :key="projId">
                    <div class="project-details-section">
                            <div v-if="detail.MediaItem" class="project-details-section-img small-order-1 medium-order-1">
                                <img :src="detail.MediaItem" alt="" />
                            </div>
                            <div v-if="detail.VideoUrl !='' && detail.VideoUrl != null" class="project-details-section-img small-order-1 medium-order-1">
                                <iframe :src="detail.VideoUrl" width="952" height="450" webkitallowfullscreen mozallowfullscreen allowfullscreen></iframe>
                            </div>
                            <div class="project-details-section-block small-order-2 medium-order-2">
                                <h3 class="project-details-section-block-header" >{{detail.Heading}}</h3>
                                <div class="details-richtext" v-html="detail.RichText"></div>
                            </div>
                        </div>
                </div>
            </div>

            <div class="show-for-small-only">
                    <div v-for="(detail, projId) in project.Details" :key="projId">
                        <div class="row text-center">
                            <h3 class="project-details-section-block-header">{{detail.Heading}}</h3>
                        </div>
                        <div class="row">
                            <div class="large-12 columns" v-html="detail.RichText"></div>
                            <div v-if="detail.MediaItem" class="large-12 columns">
                                <img :src="detail.MediaItem" alt="" />
                            </div>
                            <div v-if="detail.VideoUrl !=''  && detail.VideoUrl != null" class="large-12 columns">
                                    <iframe :src="detail.VideoUrl" width="952" height="450" webkitallowfullscreen mozallowfullscreen allowfullscreen></iframe>
                            </div>
                    </div>
                </div>
            </div>

        </div>
</template>

<script>
import axios from "axios"

export default{  
    name : "ProjectDetails",
    props: ["projectid"],
    data(){
        return {
            project:""
        }
    },
    mounted(){
        var pidUrl = "/umbraco/Api/ProjectsApi/GetProject/ssqq?projectId="+ this.projectid + "";

        axios.get(pidUrl).then(response => {
           console.log("path "+ window.location.origin + window.location.pathname);

           this.project = response.data
        });
        
    },methods:{
         track: function(){
            var pathname =  window.location.origin + window.location.pathname;
           page(pathname);
        }
    }
}
</script>