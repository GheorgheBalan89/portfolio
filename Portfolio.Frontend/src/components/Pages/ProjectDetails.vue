<template>  
     <div class="grid-container">
        <div class="grid-x grid-margin-x align-center">
            <div class="cell medium-6 text-center">
                <h1> {{project.Title}}</h1>
                <h2> {{project.Teaser}} </h2>
                <div v-html="project.Description"> {{project.Description}}</div>
            </div>
        </div>
        <div class="grid-x grid-margin-x">
            <ul>
                <li v-for="(image, key) in project.Gallery">
                    <img :src="image" />
                </li>
            </ul>
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