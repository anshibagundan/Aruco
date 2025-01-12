// domain/models/uuid.go
package models

import (
	"gorm.io/gorm"
	"time"
)

type UUID struct {
	ID        int            `json:"id" gorm:"primaryKey"`
	UUID      string         `json:"uuid" gorm:"type:varchar(36)"`
	Code      int            `json:"code"`
	CreatedAt time.Time      `json:"created_at"`
	UpdatedAt time.Time      `json:"updated_at"`
	DeletedAt gorm.DeletedAt `json:"deleted_at" gorm:"index"`
}

type UUIDResponse struct {
	UUID string `json:"uuid"`
	Code int    `json:"code"`
}

func (UUID) TableName() string {
	return "uuids"
}
