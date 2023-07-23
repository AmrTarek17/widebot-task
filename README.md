# widebot-task
## Project Info.

This project contains:
*  Infrastructure as code using [Terraform](https://www.terraform.io/) that builds an environment on the AWS cloud platform
* [Kubernetes](https://kubernetes.io) Manifests YAML files for deploying web-app, redis, sql-server
* Demo aspnetapp with Dockerfile and docker-compose file [git-repo](https://github.com/docker/awesome-compose/tree/master/aspnet-mssql)

## Task Over view

![image](https://github.com/AmrTarek17/widebot-task/assets/47079437/6c4fd6ac-9333-4846-bd0a-ca444223ce8e)

## Tools Used

* [Terraform](https://www.terraform.io/)
* [AWS](https://aws.amazon.com/)
* [Docker](https://www.docker.com/)
* [kubernetes](https://kubernetes.io)
* [redis](https://redis.io/)
* [sql-server](https://www.microsoft.com/en-us/sql-server)


## Get Started

### Get The Code 
* Using [Git](https://git-scm.com/), clone the project.

    ```
    git clone https://github.com/AmrTarek17/widebot-task.git
    ```
### Setup Infra
* First setup your aws account with cli.

* Second build the infrastructure by run

    ```bash
    cd widebot-task/terraform
    ```

    ``` 
    terraform init
    terraform apply
    ```
    that will build:
    
    * VPC named "prod-vpc"
    * 2 public Subnets
    * 2 private Subnets
    * 2 nat gateway   
    * EKS private Kubernetes cluster


       

### deploy manifests file
    
        ```bash
        # NOTE
        You need to get attached to cluster using.
        aws eks --region <region> update-kubeconfig --name <clusterName> 
        ```
    
``` 
    kubectl apply -f manifests/.
```
![image](https://github.com/AmrTarek17/widebot-task/assets/47079437/93b3ed5c-5287-4807-8005-d666c9420a96)

---

You can try my deployed web-app from [here](http://a4753f8c748e34c9590ab7cf68efe89d-1278385603.us-west-2.elb.amazonaws.com/)


:tada: :tada: :tada: :tada:
