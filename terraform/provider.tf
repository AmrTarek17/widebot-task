provider "aws"{
  shared_config_files      = ["/home/silvatron/.aws/config"]
  shared_credentials_files = ["/home/silvatron/.aws/credentials"]
  profile                  = "default"
}
