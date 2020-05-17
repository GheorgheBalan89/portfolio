<template>
    <div class="mb_parallax_container">
        <div class="mb_parallax_overlay">
            <div v-if="projectMeta != null" class="grid-x headline-container hide-for-small-only">
            <div class="medium-12 ">
                <h1 class="text-center"> {{projectMeta.Heading1}}</h1>
            </div>
            <div class="medium-12 detail-container">
                <p class="text-center">{{projectMeta.Heading2}}</p>
            </div>
           
        </div>
        <div v-if="projectMeta != null" class="headline-container-responsive show-for-small-only responsive">
            <h3 class="text-center"> {{projectMeta.Heading1}} </h3>
            <div class="text-center">{{projectMeta.Heading2}}</div>
        </div>
         <Rockets/>
    </div>
</div>

</template>
<script>
import Vue from 'vue'
import Rockets from './Rockets'
export default{
name:"Parallax",
props:['projectMeta'],

    components:{
     Rockets
    }
}
</script>