<template>
        <div v-if="project != null" class="projectlist-container details-bg">
            <div v-if="project.Detail != null" class="hero-section" v-bind:style="{ 'background-image': 'url(' + project.Detail.Hero + ')'}">  
                <div class="hero-section-text">
                    <h1 class="large-visible">   
                        {{project.General.Title}}
                    </h1>
                    <h2 class="large-hidden medium-visible">
                        {{project.General.Title}}
                    </h2>
                     <div class="text-center">
                        <h5> Client: {{project.Detail.ClientName}}  <br> Year: {{project.Detail.Year}} <br/> Role: {{ project.Detail.Role}}</h5> 
                    </div>
                    <div class="hero-description " v-html="project.General.Description"></div>
                </div>
            </div>
        
            <div v-if="project.Detail != null && project.Detail.Details != null" class="large-visible">
                  <div  v-for="(detail, projId) in project.Detail.Details" v-if="projId % 2 == 0"  :key="projId">
                    <div  class="project-details-section">
                        <div class="project-details-section-block small-order-2 medium-order-1">
                            <h3 class="project-details-section-block-header">{{detail.Heading}}</h3>
                            <div class="details-richtext text-padding-right" v-html="detail.RichText"></div>
                        </div>

                        <div v-if="detail.MediaItem" class="project-details-section-img large-order-1 medium-order-2">
                            <img :src="detail.MediaItem" alt="" />
                        </div>
                        <div v-if="detail.VideoUrl !=''  && detail.VideoUrl != null" class="project-details-section-img large-order-1 medium-order-1">
                                <iframe :src="detail.VideoUrl" width="952" height="450" webkitallowfullscreen mozallowfullscreen allowfullscreen> </iframe>
                         </div>
                    </div>
                </div>
                <div v-else :key="projId">
                    <div class="project-details-section">
                            <div v-if="detail.MediaItem" class="project-details-section-img small-order-1 medium-order-1">
                                <img :src="detail.MediaItem" alt="" />
                            </div>
                            <div v-if="detail.VideoUrl !='' && detail.VideoUrl != null" class="project-details-section-img large-order-1 medium-order-1">
                                <iframe :src="detail.VideoUrl" width="952" height="450" webkitallowfullscreen mozallowfullscreen allowfullscreen></iframe>
                            </div>
                            <div class="project-details-section-block large-order-2 medium-order-2">
                                <h3 class="project-details-section-block-header heading-padding-left" >{{detail.Heading}}</h3>
                                <div class="details-richtext text-padding-left" v-html="detail.RichText"></div>
                            </div>
                        </div>
                </div>
                &nbsp;
                &nbsp;
            </div>
           
          

        </div>
</template>

<script>
import axios from "axios"

export default{  
    name : "SingleProjectPage",
    props: ["project"],
    methods:{
         track: function(){
            var pathname =  window.location.origin + window.location.pathname;
           page(pathname);
        }
    }
}
</script>