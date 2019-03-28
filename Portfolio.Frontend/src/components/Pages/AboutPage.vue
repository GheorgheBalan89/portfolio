<template>
    <div class="grid-container  projectlist-container">
        <div class="grid-x headline-container">
            <div class="medium-12 ">
                <h1 class="text-center">
                    <div class="stroke"></div>
                    <span>NERIJA BALAN</span>
                    <div class="stroke"></div>
                </h1>
            </div>
            <div class="medium-12">
                <h2 class="text-center">UX Designer</h2>
            </div>
        </div>
        <div class="grid-x">
            <div class="medium-4 left-column">
                <h3>
                    Info
                </h3>
                <div class="stroke"></div>
                <p>Phone: 2000000000</p>
                <p>E-mail:mail@lipsum.com</p>
                <p>Website :mail@lipsum.com</p>
            </div>
            <div class="medium-8 right-column">
                <h3>Profile</h3>
                 <div class="stroke"></div>
                <p>I am a UX designer with experience in researching and developing solutions
                    that meet both users’ needs and business goals. I have more than 3 years of
                    working experience with development and implamentation of product and
                    web design.</p>
            </div>
        </div>
    </div>
</template>
<script>
import axios from "axios"

export default{
    name: 'AboutPage',
    data(){
        return {
            show:""
        };
    },
    // mounted(){
    //     axios.get("/umbraco/Api/ProjectsApi/GetFeaturedProjects?website=Nerija").then(response => {
    //         console.log(response.data.Projects);
    //         this.projects = response.data.Projects;
    //     });
    // },
    methods: {
    
    }        
 }
</script>