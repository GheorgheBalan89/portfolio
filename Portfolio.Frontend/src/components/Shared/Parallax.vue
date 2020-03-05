<template>
    <div class="mb_parallax_container">
        <div class="mb_parallax_overlay">
            <h1>Design portfolio</h1>
            <h3 v-if="projectMeta != null">{{projectMeta.Heading1}}</h3>
            <p v-if="projectMeta != null">{{projectMeta.Heading2}}></p>
        </div>
    </div>

</template>
<script>
import Vue from 'vue'

export default{
name:"Parallax",
props:['projectMeta']
}
</script>