<template>
        <div class="projectlist-container details-bg">
            <div class="hero-section" v-bind:style="{ 'background-image': 'url(' + project.Hero + ')'}">  
                <div class="hero-section-text">
                    <h3>   
                        <div class="stroke"></div>
                        {{project.Title}}
                        <div class="stroke"></div>
                    </h3>
                     <div class="text-center">
                        <h5> Client: {{project.ClientName}}  <br> Year: {{project.Year}} <br/> Role: {{ project.Role}}</h5> 
                    </div>
                    <div class="hero-description" v-html="project.Description"></div>
                   
                </div>
            </div>

            <div>
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
                                <iframe :src="'https://player.vimeo.com/video/'+detail.VideoUrl && detail.VideoUrl != null"  width="952" height="725" webkitallowfullscreen mozallowfullscreen allowfullscreen></iframe>
                          </div>
                    </div>
                </div>
                <div v-else :key="projId">
                    <div class="project-details-section">
                            <div v-if="detail.MediaItem" class="project-details-section-img small-order-1 medium-order-1">
                                <img :src="detail.MediaItem" alt="" />
                            </div>
                            <div v-if="detail.VideoUrl !='' && detail.VideoUrl != null" class="project-details-section-img small-order-1 medium-order-1">
                                <iframe :src="'https://player.vimeo.com/video/'+detail.VideoUrl" width="952" height="725" webkitallowfullscreen mozallowfullscreen allowfullscreen></iframe>
                            </div>
                            <div class="project-details-section-block small-order-2 medium-order-2">
                                <h3 class="project-details-section-block-header" >{{detail.Heading}}</h3>
                                <div class="details-richtext" v-html="detail.RichText"></div>
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