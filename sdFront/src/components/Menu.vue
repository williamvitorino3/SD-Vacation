<template>
  <div class="container-fluid">
    <nav class="nav justify-content-center">
      <a class="nav-link"></a>
      <a>
        <router-link class="nav-link" to="notas">1°</router-link>
      </a>
      <a>
        <router-link class="nav-link" to="fumante">2°</router-link>
      </a>
      <a>
        <router-link class="nav-link" to="numeros">3°</router-link>
      </a>
      <a>
        <router-link class="nav-link" to="moedas">4°</router-link>
      </a>
      <a>
        <router-link class="nav-link" to="litros">5°</router-link>
      </a>
    </nav>
    <div class="row">
      <slot></slot>
    </div>
  </div>
</template>

<script>
export default {
}
</script>

<style scoped>
</style>
