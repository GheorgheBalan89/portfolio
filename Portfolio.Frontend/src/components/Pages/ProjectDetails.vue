<template>  
        <div class="projectlist-container details-bg">
            <div class="headline-container">
                <h1 class="text-center">{{project.Title}}</h1>
                <h4 class="text-center">{{project.Teaser}}</h4>
            </div>
            <div>
                <div v-for="(detail, projId) in project.Details" v-if="projId % 2 == 0" name="bounceInRight" :key="projId"  delay="0s" duration="0s" :iteration="0" :offset="0" animateClass="bounceInRight" :begin="false"  >
                    <div  class="project-details-section">
                        <div class="project-details-section-block small-order-2 medium-order-1">
                            <h3 class="project-details-section-block-header">{{detail.Heading}}</h3>
                            <div v-html="detail.RichText"></div>
                        </div>
                        <div class="project-details-section-img small-order-1 medium-order-2">
                            <img :src="detail.MediaItem" alt="" />
                        </div>
                    </div>
                </div>
                <div v-else name="bounceInLeft"  delay="0s" duration="0s" :key="projId" :iteration="0" :offset="0" animateClass="bounceInLeft" :begin="false">
                    <div class="project-details-section slideInRight">
                            <div class="project-details-section-img small-order-1 medium-order-1">
                                <img :src="detail.MediaItem" alt="" />
                            </div>
                            <div class="project-details-section-block small-order-2 medium-order-2">
                                <h3 class="project-details-section-block-header" >{{detail.Heading}}</h3>
                                <div v-html="detail.RichText"></div>
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
            console.log(response.data);
            // this.navData = response.data;
            this.project = response.data
        });
        
    },
}
</script>